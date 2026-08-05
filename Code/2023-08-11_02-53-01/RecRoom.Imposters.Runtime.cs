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
public class ImposterPreviewCustomFraming : MonoBehaviour, NGNDOCANFDG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float CINDIEMJGED = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	public void PrepareImposter(BKFNFLBPMOF LGKGBPHHHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A720", Offset = "0x6D68F20", VA = "0x186D6A720")]
	public void SetReferencePoint(Vector3 GGKJMICDBEF, Quaternion CCIFDEOEEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A590", Offset = "0x6D68D90", VA = "0x186D6A590")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A6F0", Offset = "0x6D68EF0", VA = "0x186D6A6F0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A760", Offset = "0x6D68F60", VA = "0x186D6A760")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CHDNOFHCLAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BNMKPBMPNMI LPNBDMDGKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture CPGCECOMONC;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A72C0", Offset = "0x8A5AC0", VA = "0x1808A72C0")]
		public CHDNOFHCLAA(BNMKPBMPNMI LELEAPNNCGP, Texture PBPDIAHBBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum KJEANPEHFMI
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
	private class IBMPGHGEHJL : NMAKHDNAMLE<Texture>, MLNMOGMEOOE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class CGNDKJGJLGN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public IBMPGHGEHJL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public CGNDKJGJLGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6D67530", Offset = "0x6D65D30", VA = "0x186D67530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly BNMKPBMPNMI LELEAPNNCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture DLDEBMKDNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig OGEENPIAOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken NNLBJPBEHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject LBLGEPIGCKM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public JJMNNLLBAJO<Texture> HHILEEBKNEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6A220", Offset = "0x6D68A20", VA = "0x186D6A220", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Task<Texture> BHHOIJLGAIH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A3C0", Offset = "0x6D68BC0", VA = "0x186D6A3C0")]
		public IBMPGHGEHJL(BNMKPBMPNMI LELEAPNNCGP, RenderTexture DLDEBMKDNDA, ImposterRenderConfig OGEENPIAOLA, CancellationToken NNLBJPBEHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A270", Offset = "0x6D68A70", VA = "0x186D6A270")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CGNDKJGJLGN))]
		private Task<Texture> JFDGAFIDMHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A180", Offset = "0x6D68980", VA = "0x186D6A180", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A190", Offset = "0x6D68990", VA = "0x186D6A190")]
		private static void EHCCOPFPDGG(GameObject LBLGEPIGCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OLONJPILKGH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OLONJPILKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D310", Offset = "0x6D6BB10", VA = "0x186D6D310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
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
	[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private KJEANPEHFMI size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[PJEFHHPNPOL("size", 0)]
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
	private RenderTexture NBBGHFJJPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private IIOPHFANMIH<GameObject> DHGLKBMGLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KIPKMCKINOD LIKAHCDOBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource EFIOOPGMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private NMAKHDNAMLE<Texture> EGKAMMDHPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BNMKPBMPNMI PCNPLHHIMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture AAGGFFHELKE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture BHPFLPDOLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A8B0", Offset = "0x6D690B0", VA = "0x186D6A8B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA744F0", Offset = "0xA72CF0", VA = "0x180A744F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private BNMKPBMPNMI LPNBDMDGKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AB30", Offset = "0x6D69330", VA = "0x186D6AB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool LDNGDENKFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1E9B0", Offset = "0xA1D1B0", VA = "0x180A1E9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EEMICAEHHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AB20", Offset = "0x6D69320", VA = "0x186D6AB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A7A0", Offset = "0x6D68FA0", VA = "0x186D6A7A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AD10", Offset = "0x6D69510", VA = "0x186D6AD10")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AC80", Offset = "0x6D69480", VA = "0x186D6AC80")]
	private void OOCDOEHJJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B020", Offset = "0x6D69820", VA = "0x186D6B020")]
	public void Set(BNMKPBMPNMI BHAOAPDGIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B030", Offset = "0x6D69830", VA = "0x186D6B030")]
	public void Set(Texture PBPDIAHBBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B040", Offset = "0x6D69840", VA = "0x186D6B040")]
	public void Set(CHDNOFHCLAA MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A7B0", Offset = "0x6D68FB0", VA = "0x186D6A7B0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AE10", Offset = "0x6D69610", VA = "0x186D6AE10")]
	public void SetInternal(BNMKPBMPNMI BHAOAPDGIBG, [Optional] Texture BEPAGFLLOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AE00", Offset = "0x6D69600", VA = "0x186D6AE00")]
	public void SetCustomSize(int PODDKAKBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xBBF230", Offset = "0xBBDA30", VA = "0x180BBF230")]
	public void SetAntiAliasing(int ANHGKLKHMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AA40", Offset = "0x6D69240", VA = "0x186D6AA40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OLONJPILKGH))]
	private void HLFFGKGFNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A7C0", Offset = "0x6D68FC0", VA = "0x186D6A7C0")]
	private void GFODIBLDAFN(Texture PBPDIAHBBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B080", Offset = "0x6D69880", VA = "0x186D6B080")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GIIJMLBDJIM
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static GIIJMLBDJIM BGFOJMAODME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float OJIAMEOHFGG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x31E49A0", Offset = "0x31E31A0", VA = "0x1831E49A0")]
	public GIIJMLBDJIM(float ANIENKOGFJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct NHOONPLNCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly BNMKPBMPNMI ILCCPLEMAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string FNCHNPJAGCH;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB84550", Offset = "0xB82D50", VA = "0x180B84550")]
		public NHOONPLNCPC(BNMKPBMPNMI GAOEFNEHIIH, string PCCFCNIMEFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EADFBODINOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NHOONPLNCPC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private BNMKPBMPNMI <request>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EADFBODINOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6D68D70", Offset = "0x6D67570", VA = "0x186D68D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider ILBICKMDAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private AIPCCPPOHIA<NHOONPLNCPC, GameObject> FAHGEEGGMHH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GDGPGOAIJHI MPHKLNBOOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private AIPCCPPOHIA<NHOONPLNCPC, GameObject> NFPMNICEIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D687F0", Offset = "0x6D66FF0", VA = "0x186D687F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int MOMHBFCENNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D687A0", Offset = "0x6D66FA0", VA = "0x186D687A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D686F0", Offset = "0x6D66EF0", VA = "0x186D686F0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D68CC0", Offset = "0x6D674C0", VA = "0x186D68CC0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D68B20", Offset = "0x6D67320", VA = "0x186D68B20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EADFBODINOD))]
	private Task<GameObject> NGJIBHLBALD(NHOONPLNCPC DEMONLGCJCL, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D68950", Offset = "0x6D67150", VA = "0x186D68950")]
	public Task<GameObject> LoadItemAsync(BNMKPBMPNMI GAOEFNEHIIH, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D68D30", Offset = "0x6D67530", VA = "0x186D68D30")]
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
		[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int LADOKPBBNDM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int AHEDBHHJFML = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> ALOKFJBAHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool MOCDICENFDM;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B260", Offset = "0x6D69A60", VA = "0x186D6B260")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B170", Offset = "0x6D69970", VA = "0x186D6B170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B4B0", Offset = "0x6D69CB0", VA = "0x186D6B4B0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BNMKPBMPNMI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string BOCGJPILADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GIIJMLBDJIM GIIJMLBDJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AOGOKCHNDMF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> OLCCFGJFLDK(CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EDEIOAAABHB(BNMKPBMPNMI OALEAAIPGBP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGOLFICDHPL();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDNCGJMIMPG();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BHECHIIAAKI(out NMAKHDNAMLE<Texture> BAOPLPJKCOE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CFHKNNCLGLC
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D67460", Offset = "0x6D65C60", VA = "0x186D67460")]
	public static bool MLFPLHENGEN(BNMKPBMPNMI HBDPIACPCPD, BNMKPBMPNMI OEGDNKGMJOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ABJFKJLAEIL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<Type> MPMJBNDBAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> MHGPKGFMOCF
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
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GDGPGOAIJHI
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject LCDEMLFJGCI(GameObject ALNJPMNLFGF, Transform GJPBCFJDGCH, bool FAHKKKBFKOH = false);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LCDEMLFJGCI<T>(T ALNJPMNLFGF, Transform GJPBCFJDGCH, bool FAHKKKBFKOH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T LCDEMLFJGCI<T>(GameObject ALNJPMNLFGF, Transform GJPBCFJDGCH, bool FAHKKKBFKOH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject LCDEMLFJGCI(GameObject ALNJPMNLFGF, Transform GJPBCFJDGCH, BKFNFLBPMOF LGKGBPHHHBD, bool FAHKKKBFKOH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NCDHNFOCNDF
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> PFBIAPGCGMI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 CCHJJAAPIHA;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 EAFCGEKHNMO;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera CCBBOGKFKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Renderer> CLBDHAKFJDL;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static AmbientMode DBHJPDLHOPJ;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static Color MCCOCAGGCCL;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static Color AELPANANOJC;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color CGLBOPLCDFH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Cubemap DNOPKMBENJD;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static bool PJNNHPLJHKM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static Camera LDDPJGFBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B8F0", Offset = "0x6D6A0F0", VA = "0x186D6B8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CA00", Offset = "0x6D6B200", VA = "0x186D6CA00")]
	public static void NDPHKOCMAML(Vector3 PFHOHILMMOA, Quaternion MMBADKAOGKM, ImposterRenderConfig EDAJNDPMHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B570", Offset = "0x6D69D70", VA = "0x186D6B570")]
	private static void DHBLDJHKPNI(Vector3 PFHOHILMMOA, Quaternion MMBADKAOGKM, URPLight GGKMGDOBKGC, ImposterRenderConfig.LightConfig EJLPAEFADEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BB30", Offset = "0x6D6A330", VA = "0x186D6BB30")]
	public static void INDJCEODLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CC80", Offset = "0x6D6B480", VA = "0x186D6CC80")]
	private static void OIAGDEBAABL(int JBDNEDKBOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D050", Offset = "0x6D6B850", VA = "0x186D6D050")]
	public static void PKCCLEJBDLO(ImposterRenderConfig EDAJNDPMHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BF20", Offset = "0x6D6A720", VA = "0x186D6BF20")]
	public static void KNEKLLILDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C830", Offset = "0x6D6B030", VA = "0x186D6C830")]
	public static void MPOFNHGICCG(GameObject KIKGNCLFCKC, RenderTexture DLDEBMKDNDA, ImposterRenderConfig EDAJNDPMHHM, GIIJMLBDJIM NLAGPFBDELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C020", Offset = "0x6D6A820", VA = "0x186D6C020")]
	private static void LDCOMBKEMKF(GameObject KIKGNCLFCKC, RenderTexture DLDEBMKDNDA, ImposterRenderConfig EDAJNDPMHHM, GIIJMLBDJIM NLAGPFBDELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C580", Offset = "0x6D6AD80", VA = "0x186D6C580")]
	private static void MLCEPDJOGOC(GameObject KIKGNCLFCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BC20", Offset = "0x6D6A420", VA = "0x186D6BC20")]
	public static void KKJIGDKIHMM(GameObject ALNJPMNLFGF, Vector3 DGNAKBDOHBF, Vector3 GKLDBFODIAP, float PDDAIMMPHAC, GIIJMLBDJIM NLAGPFBDELD, out Vector3 BBLJANNLKMC, out Quaternion FJMBPDJDNJL, out float BAMFLBGMAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B850", Offset = "0x6D6A050", VA = "0x186D6B850")]
	public static RenderTexture DNNDANEOGCG(int JHBGPLBIFPC, int AJHBENNHBJK)
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
		public struct HDECOJJOKGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public ACOJIJEEGAO JKKHPKEDPHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public GameObject LKGIALJPGNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public RenderTexture BHPFLPDOLKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public ImposterRenderConfig HFKNMGLBKKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public GIIJMLBDJIM GIIJMLBDJIM;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6D691C0", Offset = "0x6D679C0", VA = "0x186D691C0")]
			public HDECOJJOKGO(ACOJIJEEGAO IAHNODEPOMP, GameObject CHPMHJGDOFB, RenderTexture DLDEBMKDNDA, ImposterRenderConfig OGEENPIAOLA, GIIJMLBDJIM NLAGPFBDELD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static AIPCCPPOHIA<HDECOJJOKGO, RenderTexture> IGFBLMGJOPN;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<HDECOJJOKGO> IOGPLJDNBPC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private static int AAJLGBCEHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6D681E0", Offset = "0x6D669E0", VA = "0x186D681E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D682F0", Offset = "0x6D66AF0", VA = "0x186D682F0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KIKGNCLFCKC, RenderTexture DLDEBMKDNDA, ImposterRenderConfig EDAJNDPMHHM, GIIJMLBDJIM NLAGPFBDELD, CancellationToken NNLBJPBEHPF, bool OOCBEANHHLI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D67E20", Offset = "0x6D66620", VA = "0x186D67E20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D68250", Offset = "0x6D66A50", VA = "0x186D68250", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D68010", Offset = "0x6D66810", VA = "0x186D68010")]
		private static Task<RenderTexture> IOGJCJFMOMI(HDECOJJOKGO KCCKLHHBDOJ, CancellationToken NNLBJPBEHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D686B0", Offset = "0x6D66EB0", VA = "0x186D686B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D6B550", Offset = "0x6D69D50", VA = "0x186D6B550")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B530", Offset = "0x6D69D30", VA = "0x186D6B530")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B120", Offset = "0x6D69920", VA = "0x186D6B120")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HLJGDHJEDJJ : IDisposable, GDGPGOAIJHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly HashSet<Type> IKICEONPNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HashSet<Type> GCLJOBJJOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Transform OEGAIMLADIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly List<Component> DEFJGFALDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BBOONJKAOFB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D698A0", Offset = "0x6D680A0", VA = "0x186D698A0")]
	[NFOBBCLLFPP(BGPNPCEMJLD.None)]
	public static void EKIONAIJAEJ(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D69D40", Offset = "0x6D68540", VA = "0x186D69D40")]
	[Preserve]
	public HLJGDHJEDJJ([JHPEMCNOMHI(null)] ABJFKJLAEIL LKIFKKHGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D69230", Offset = "0x6D67A30", VA = "0x186D69230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D69B50", Offset = "0x6D68350", VA = "0x186D69B50", Slot = "5")]
	public GameObject LCDEMLFJGCI(GameObject ALNJPMNLFGF, Transform GJPBCFJDGCH, bool FAHKKKBFKOH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A1E6D0", Offset = "0x2A1CED0", VA = "0x182A1E6D0", Slot = "6")]
	public T LCDEMLFJGCI<T>(T ALNJPMNLFGF, Transform GJPBCFJDGCH, bool FAHKKKBFKOH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A1E740", Offset = "0x2A1CF40", VA = "0x182A1E740", Slot = "7")]
	public T LCDEMLFJGCI<T>(GameObject ALNJPMNLFGF, Transform GJPBCFJDGCH, bool FAHKKKBFKOH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D69AC0", Offset = "0x6D682C0", VA = "0x186D69AC0", Slot = "8")]
	public GameObject LCDEMLFJGCI(GameObject ALNJPMNLFGF, Transform GJPBCFJDGCH, BKFNFLBPMOF LGKGBPHHHBD, bool FAHKKKBFKOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A1E680", Offset = "0x2A1CE80", VA = "0x182A1E680", Slot = "9")]
	public T LCDEMLFJGCI<T>(GameObject ALNJPMNLFGF, Transform GJPBCFJDGCH, BKFNFLBPMOF LGKGBPHHHBD, bool FAHKKKBFKOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2A1E160", Offset = "0x2A1C960", VA = "0x182A1E160")]
	private T LCDEMLFJGCI<T>(GameObject ALNJPMNLFGF, Transform GJPBCFJDGCH, BKFNFLBPMOF LGKGBPHHHBD, bool FAHKKKBFKOH, out GameObject HHGLAHHMKLO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2A1DBB0", Offset = "0x2A1C3B0", VA = "0x182A1DBB0")]
	private T HDFGEBJCOBI<T>(GameObject OAOEKKJFJKH, BKFNFLBPMOF LGKGBPHHHBD, bool FAHKKKBFKOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D69990", Offset = "0x6D68190", VA = "0x186D69990")]
	private void FMPEPECLKJA(Component CAOCJIHJELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D69330", Offset = "0x6D67B30", VA = "0x186D69330")]
	private void ECCNBLKFENJ(Component CAOCJIHJELH, BKFNFLBPMOF LGKGBPHHHBD, bool FAHKKKBFKOH, bool HIGJHDIGIDL, [Optional] Type BDFIILKAPJI, [Optional] Type PKPFDKPLLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D69BE0", Offset = "0x6D683E0", VA = "0x186D69BE0")]
	private void PMPJCLCCCEG(GameObject OAOEKKJFJKH)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, NGNDOCANFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D67CC0", Offset = "0x6D664C0", VA = "0x186D67CC0", Slot = "4")]
		public void PrepareImposter(BKFNFLBPMOF LGKGBPHHHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BKFNFLBPMOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Dictionary<Type, object> DIGPLEIOAMI;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1E679D0", Offset = "0x1E661D0", VA = "0x181E679D0")]
	public BKFNFLBPMOF OLFLGMGEIBD<T>(T GOCFCPGBDBC)
	{
		return default(BKFNFLBPMOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1E670B0", Offset = "0x1E658B0", VA = "0x181E670B0")]
	public T LPKBLHIFLLL<T>(T GFJIAKNDNMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1E671D0", Offset = "0x1E659D0", VA = "0x181E671D0")]
	public bool NOPGAJGAFLG<T>(out T GOCFCPGBDBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DJAGINKJINI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool LPAOGNFIMKF;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x123C7B0", Offset = "0x123AFB0", VA = "0x18123C7B0")]
	public DJAGINKJINI(bool FGNFILLKDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CBGEDFFHFHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool NOGDAHFICJK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D67450", Offset = "0x6D65C50", VA = "0x186D67450")]
	public CBGEDFFHFHK(bool PNMCKEJOKDD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, NGNDOCANFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D6DAF0", Offset = "0x6D6C2F0", VA = "0x186D6DAF0", Slot = "4")]
		public void PrepareImposter(BKFNFLBPMOF LGKGBPHHHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NGNDOCANFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BKFNFLBPMOF LGKGBPHHHBD);
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

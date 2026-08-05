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
	private readonly struct JOMIGMELIOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly GOENHECEOJI OKEBILKNKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string GMKJCBCMFOD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
		public JOMIGMELIOD(GOENHECEOJI IAPBLKIEADM, string AFEDPCMDNPE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct HEPOACFCBOE : IAsyncStateMachine
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
		public JOMIGMELIOD queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E20E30", Offset = "0x6E1F830", VA = "0x186E20E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E211F0", Offset = "0x6E1FBF0", VA = "0x186E211F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider OAKMKCFIEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PIIGHBDKEIF<JOMIGMELIOD, GameObject> LDJKPFANOKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HIIJGMBLMPG BDDGHFCFOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private PIIGHBDKEIF<JOMIGMELIOD, GameObject> MKLDIMAEKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E1FA20", Offset = "0x6E1E420", VA = "0x186E1FA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int IECDNHBOAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F9D0", Offset = "0x6E1E3D0", VA = "0x186E1F9D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F8F0", Offset = "0x6E1E2F0", VA = "0x186E1F8F0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FE80", Offset = "0x6E1E880", VA = "0x186E1FE80", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FD60", Offset = "0x6E1E760", VA = "0x186E1FD60")]
	[AsyncStateMachine(typeof(HEPOACFCBOE))]
	private Task<GameObject> MHKFNPPFGAP(JOMIGMELIOD AEPNEMGIGJE, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FB80", Offset = "0x6E1E580", VA = "0x186E1FB80")]
	public Task<GameObject> LoadItemAsync(GOENHECEOJI IAPBLKIEADM, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FEF0", Offset = "0x6E1E8F0", VA = "0x186E1FEF0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NOIHOHELLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GOENHECEOJI OAKFPCKIHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture EPKEONCIMIJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
		public NOIHOHELLPF(GOENHECEOJI OACKAJJPCHA, Texture AGFHPNOIBGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum GHDEMDOJFKE
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
	private class KCJJFLEAKKK : IFDKEOABGPN<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AIJCNJLDBDL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KCJJFLEAKKK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6E1DC60", Offset = "0x6E1C660", VA = "0x186E1DC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E460", Offset = "0x6E1CE60", VA = "0x186E1E460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly GOENHECEOJI OACKAJJPCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture IAJEILDCCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig FOADDELBOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken PPLDCJFFMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D BDBHGMBEIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject LPCILFJKPDJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override BJOGDIODDMJ<Texture2D> PGNIBKFPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6E24ED0", Offset = "0x6E238D0", VA = "0x186E24ED0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> FKKJDMMKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E24F30", Offset = "0x6E23930", VA = "0x186E24F30")]
		public KCJJFLEAKKK(GOENHECEOJI OACKAJJPCHA, RenderTexture IAJEILDCCAB, ImposterRenderConfig FOADDELBOEA, CancellationToken PPLDCJFFMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E24D60", Offset = "0x6E23760", VA = "0x186E24D60")]
		[AsyncStateMachine(typeof(AIJCNJLDBDL))]
		private Task<Texture2D> ICABDMAHKPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E24D30", Offset = "0x6E23730", VA = "0x186E24D30", Slot = "10")]
		protected override void DBGDDHAMGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E24E50", Offset = "0x6E23850", VA = "0x186E24E50")]
		private static void MEELPKNCCDC(GameObject LPCILFJKPDJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BMKGJMIFEBE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6E1E550", Offset = "0x6E1CF50", VA = "0x186E1E550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
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
	[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private GHDEMDOJFKE size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[AGHNKJDJPHK("size", GHDEMDOJFKE.Custom)]
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
	private static int POGLBIHGHCN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture DKMPNGKLPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private BGKKINKPIKB<GameObject> CLBIJEALHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private OLPMMAHKODD EKIPLCAAHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource KPJNJINNMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FFCGNKADKHD<Texture2D> IALIIEPLEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GOENHECEOJI NHOLCFPNDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture HPFDIBHDOGF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int HANHMOOEDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E24810", Offset = "0x6E23210", VA = "0x186E24810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E24860", Offset = "0x6E23260", VA = "0x186E24860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture JANDMINIIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E23F90", Offset = "0x6E22990", VA = "0x186E23F90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8AD550", Offset = "0x8ABF50", VA = "0x1808AD550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GOENHECEOJI OAKFPCKIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1C0", Offset = "0x8A9BC0", VA = "0x1808AB1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E24170", Offset = "0x6E22B70", VA = "0x186E24170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool HOPMPIEKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1A31CD0", Offset = "0x1A306D0", VA = "0x181A31CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int PKCCPELJMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E24350", Offset = "0x6E22D50", VA = "0x186E24350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E23DE0", Offset = "0x6E227E0", VA = "0x186E23DE0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E243E0", Offset = "0x6E22DE0", VA = "0x186E243E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E242D0", Offset = "0x6E22CD0", VA = "0x186E242D0")]
	private void HACFEOMBJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E24730", Offset = "0x6E23130", VA = "0x186E24730")]
	public void Set(GOENHECEOJI JLLKAFFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E24720", Offset = "0x6E23120", VA = "0x186E24720")]
	public void Set(Texture AGFHPNOIBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E246E0", Offset = "0x6E230E0", VA = "0x186E246E0")]
	public void Set(NOIHOHELLPF PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E23ED0", Offset = "0x6E228D0", VA = "0x186E23ED0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E244E0", Offset = "0x6E22EE0", VA = "0x186E244E0")]
	public void SetInternal(GOENHECEOJI JLLKAFFPEMG, [Optional] Texture KHGMFODJKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E244D0", Offset = "0x6E22ED0", VA = "0x186E244D0")]
	public void SetCustomSize(int GBLJJENNOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8AD760", Offset = "0x8AC160", VA = "0x1808AD760")]
	public void SetAntiAliasing(int GEIELEBHGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E23EE0", Offset = "0x6E228E0", VA = "0x186E23EE0")]
	[AsyncStateMachine(typeof(BMKGJMIFEBE))]
	private void ELKKHJBKLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E23DF0", Offset = "0x6E227F0", VA = "0x186E23DF0")]
	private void BOHJGMNIOHM(Texture AGFHPNOIBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E24790", Offset = "0x6E23190", VA = "0x186E24790")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, BDHDDEMLKGD
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float BMCKPGJKAEN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
	public void PrepareImposter(LOGOJCKBJLN DIEJPPEOGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E23DA0", Offset = "0x6E227A0", VA = "0x186E23DA0")]
	public void SetReferencePoint(Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E23BB0", Offset = "0x6E225B0", VA = "0x186E23BB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E23D80", Offset = "0x6E22780", VA = "0x186E23D80")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1937FD0", Offset = "0x19369D0", VA = "0x181937FD0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ELBODICMKDE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static ELBODICMKDE HPGAEEGKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float LLKAHMBPBIP;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2452070", Offset = "0x2450A70", VA = "0x182452070")]
	public ELBODICMKDE(float PKEGIKPCNLG)
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
		[Cpp2IlInjected.Address(RVA = "0x6E253D0", Offset = "0x6E23DD0", VA = "0x186E253D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
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
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int NMOJGNAFINI = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int CKIFLAOGIEC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> LPCNHPAJILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool OODHCHMOHKL;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E24A60", Offset = "0x6E23460", VA = "0x186E24A60")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E24960", Offset = "0x6E23360", VA = "0x186E24960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E24CA0", Offset = "0x6E236A0", VA = "0x186E24CA0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GOENHECEOJI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string OBOOAABDGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ELBODICMKDE ELBODICMKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MKDIJOPFIFA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GCKPOKOGHPD(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PHKGPIODJOL(GOENHECEOJI GDOGPMPJPOO);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABBAAHPGBKF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GCDPAONNAMN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JECEEKCPAFH(uint? KPGOIDMPAOI, [Out] FFCGNKADKHD<Texture2D> HNJLNDGKCKG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HNFJJIMBKDG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E21260", Offset = "0x6E1FC60", VA = "0x186E21260")]
	public static bool LLAKBJMMIBF(GOENHECEOJI NBECCJPBDOP, GOENHECEOJI NBJLJFMNMGI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, BDHDDEMLKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E1ED90", Offset = "0x6E1D790", VA = "0x186E1ED90", Slot = "4")]
		public void PrepareImposter(LOGOJCKBJLN DIEJPPEOGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BDHDDEMLKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LOGOJCKBJLN DIEJPPEOGBB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GFPIPHFNFLK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> EFCHGLDIIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> FKAOPHPKEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HIIJGMBLMPG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIHLAHGBHGK(params Type[] ICNGEOBELEM);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject EEJJBMJPEAM(GameObject BBIOBOHHGAF, Transform NNFBEGDDJKL, bool APPNOLKDMOH = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T EEJJBMJPEAM<T>(T BBIOBOHHGAF, Transform NNFBEGDDJKL, bool APPNOLKDMOH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T EEJJBMJPEAM<T>(GameObject BBIOBOHHGAF, Transform NNFBEGDDJKL, bool APPNOLKDMOH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject EEJJBMJPEAM(GameObject BBIOBOHHGAF, Transform NNFBEGDDJKL, LOGOJCKBJLN DIEJPPEOGBB, bool APPNOLKDMOH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HEJBMONCHGO : IDisposable, HIIJGMBLMPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> DDCJBDOGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> HLHNCOMKLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform PDLODAOFNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> PBHPHGCHIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> FGMMMGLNFHI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E20080", Offset = "0x6E1EA80", VA = "0x186E20080")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	public static void DJJNDGGBFEG(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E209F0", Offset = "0x6E1F3F0", VA = "0x186E209F0")]
	[UnityEngine.Scripting.Preserve]
	public HEJBMONCHGO([CCLEDEMDDDH(null)] GFPIPHFNFLK LFIMMMDJOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E20180", Offset = "0x6E1EB80", VA = "0x186E20180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E209A0", Offset = "0x6E1F3A0", VA = "0x186E209A0", Slot = "5")]
	public void PIHLAHGBHGK(params Type[] ICNGEOBELEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E20260", Offset = "0x6E1EC60", VA = "0x186E20260", Slot = "6")]
	public GameObject EEJJBMJPEAM(GameObject BBIOBOHHGAF, Transform NNFBEGDDJKL, bool APPNOLKDMOH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC950", Offset = "0x2EFB350", VA = "0x182EFC950", Slot = "7")]
	public T EEJJBMJPEAM<T>(T BBIOBOHHGAF, Transform NNFBEGDDJKL, bool APPNOLKDMOH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC900", Offset = "0x2EFB300", VA = "0x182EFC900", Slot = "8")]
	public T EEJJBMJPEAM<T>(GameObject BBIOBOHHGAF, Transform NNFBEGDDJKL, bool APPNOLKDMOH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E202F0", Offset = "0x6E1ECF0", VA = "0x186E202F0", Slot = "9")]
	public GameObject EEJJBMJPEAM(GameObject BBIOBOHHGAF, Transform NNFBEGDDJKL, LOGOJCKBJLN DIEJPPEOGBB, bool APPNOLKDMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC8A0", Offset = "0x2EFB2A0", VA = "0x182EFC8A0", Slot = "10")]
	public T EEJJBMJPEAM<T>(GameObject BBIOBOHHGAF, Transform NNFBEGDDJKL, LOGOJCKBJLN DIEJPPEOGBB, bool APPNOLKDMOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC9E0", Offset = "0x2EFB3E0", VA = "0x182EFC9E0")]
	private T EEJJBMJPEAM<T>(GameObject BBIOBOHHGAF, Transform NNFBEGDDJKL, LOGOJCKBJLN DIEJPPEOGBB, bool APPNOLKDMOH, [Out] GameObject KJBPMPNNGDP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2EFCF60", Offset = "0x2EFB960", VA = "0x182EFCF60")]
	private T NGIABJAFBDE<T>(GameObject NJFNKLJIFDE, LOGOJCKBJLN DIEJPPEOGBB, bool APPNOLKDMOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FF70", Offset = "0x6E1E970", VA = "0x186E1FF70")]
	private void DAGPOCPEGPJ(Component LHCHHCODKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E20380", Offset = "0x6E1ED80", VA = "0x186E20380")]
	private void HCHMLAMIGFG(Component LHCHHCODKCC, LOGOJCKBJLN DIEJPPEOGBB, bool APPNOLKDMOH, bool DPHPLKOKFNG, [Optional] Type ECPIBKOBEJG, [Optional] Type NPBAMEEHENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E20830", Offset = "0x6E1F230", VA = "0x186E20830")]
	private void NJKBFHJOEII(GameObject NJFNKLJIFDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LOGOJCKBJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> CPMNEKBNJEJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2910", Offset = "0x2FC1310", VA = "0x182FC2910")]
	public LOGOJCKBJLN CADIEIMFLMA<T>(T KIFBJCPFHMF)
	{
		return default(LOGOJCKBJLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3810", Offset = "0x2FC2210", VA = "0x182FC3810")]
	public T KJCABELIABF<T>(T PFGHNJEFBFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3040", Offset = "0x2FC1A40", VA = "0x182FC3040")]
	public bool HCJNPMNOANM<T>([Out] T KIFBJCPFHMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DFKFBMKJEHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool MALGCIJAGBM;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2452AC0", Offset = "0x24514C0", VA = "0x182452AC0")]
	public DFKFBMKJEHH(bool MBLCFCEMAKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct APIAMPHFLDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool HFPJCIJBIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E4D0", Offset = "0x6E1CED0", VA = "0x186E1E4D0")]
	public APIAMPHFLDN(bool JPJPKJJNHOL)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, BDHDDEMLKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E25120", Offset = "0x6E23B20", VA = "0x186E25120", Slot = "4")]
		public void PrepareImposter(LOGOJCKBJLN DIEJPPEOGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
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
		public Bounds PDIOAGJAHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6E23A20", Offset = "0x6E22420", VA = "0x186E23A20")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E239E0", Offset = "0x6E223E0", VA = "0x186E239E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E239A0", Offset = "0x6E223A0", VA = "0x186E239A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E238B0", Offset = "0x6E222B0", VA = "0x186E238B0")]
		private void DMAOILDGEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
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
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x6E25100", Offset = "0x6E23B00", VA = "0x186E25100")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E250F0", Offset = "0x6E23AF0", VA = "0x186E250F0")]
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
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E248D0", Offset = "0x6E232D0", VA = "0x186E248D0")]
		public void NEGOIFOPGLD(Vector3 DFLNFCIFCPK, Quaternion JFFMCMGMNNB, float BJAKHEOMJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E24900", Offset = "0x6E23300", VA = "0x186E24900")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class ICGLCFHKIJN
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly Vector3 MLEPKBOGKCF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<URPLight> KBHNJEGCILK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly List<Light> EOOPJCBHFLL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Camera KFLFENNMLMG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<Renderer> FCMONNDNAIE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly List<ImposterBoundsOverride> KEGKIFOCLGH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static AmbientMode NDAJEOICJKB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color ANPDCOOICEM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color IHCIKBOPLLL;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Color KODDFGPKLOG;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static Cubemap GFKOKDMPNEB;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static bool NKNINKCMEBE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> ELJFNHODEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E22BA0", Offset = "0x6E215A0", VA = "0x186E22BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> KEOEHGLHILK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E22BF0", Offset = "0x6E215F0", VA = "0x186E22BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera BGIHGKCBLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E22130", Offset = "0x6E20B30", VA = "0x186E22130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E22360", Offset = "0x6E20D60", VA = "0x186E22360")]
	public static void DBPKAJEFCIC(Vector3 FMDLBBFDLBO, Quaternion INLEFNNPGHK, ImposterRenderConfig HJPIJKAMNJE, bool LOMGNDOIMNI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E227A0", Offset = "0x6E211A0", VA = "0x186E227A0")]
	private static void KJIJEDFPIKB(Vector3 FMDLBBFDLBO, Quaternion INLEFNNPGHK, URPLight FIMFCIKPPLN, ImposterRenderConfig.LightConfig DEKAENHCKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E225F0", Offset = "0x6E20FF0", VA = "0x186E225F0")]
	public static void DIFKIOAAHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E23290", Offset = "0x6E21C90", VA = "0x186E23290")]
	private static void PBFNPBIIFAC(int FBHNOCDHMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E21350", Offset = "0x6E1FD50", VA = "0x186E21350")]
	public static void ADLEEILBCHD(ImposterRenderConfig HJPIJKAMNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E22AC0", Offset = "0x6E214C0", VA = "0x186E22AC0")]
	public static void OFDLNHCPONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E21B30", Offset = "0x6E20530", VA = "0x186E21B30")]
	public static void BIFJFEJCLKA(GameObject LKBEHKNIHFM, RenderTexture IAJEILDCCAB, ImposterRenderConfig HJPIJKAMNJE, ELBODICMKDE GLLIGEFOBFP, [Optional] Vector3? JLKLCHNDJPA, [Optional] Vector3? CODJPEJNNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E21500", Offset = "0x6E1FF00", VA = "0x186E21500")]
	private static void ANIFMKNCANB(GameObject LKBEHKNIHFM, RenderTexture IAJEILDCCAB, ImposterRenderConfig HJPIJKAMNJE, ELBODICMKDE GLLIGEFOBFP, Vector3 JLKLCHNDJPA, Vector3 CODJPEJNNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E21E70", Offset = "0x6E20870", VA = "0x186E21E70")]
	private static void BJFNHLBIHIP(GameObject LKBEHKNIHFM, Vector3 ALAIMABEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E22C40", Offset = "0x6E21640", VA = "0x186E22C40")]
	private static void PAILNAAFCJI(GameObject BBIOBOHHGAF, ImposterRenderConfig HJPIJKAMNJE, ELBODICMKDE GLLIGEFOBFP, [Out] Vector3 NCIPJIPGMDF, [Out] Quaternion CCKHBHBGCLG, [Out] float MIPBOPFJKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E226D0", Offset = "0x6E210D0", VA = "0x186E226D0")]
	public static RenderTexture EBLNJDBJHAI(int DOMGNHCOIKC, int CDNBAPPHFBG, RenderTextureFormat ICABLEDECHB = RenderTextureFormat.ARGB32, string AGAFIGJOGHL = "[ImposterRendering]Preview")
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
		public struct BFLDAGDKBIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public EMDNAJFOAMA FDDJBPCGKEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public GameObject IBDMDNKCHIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RenderTexture JANDMINIIPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ImposterRenderConfig BPBBNNKGGAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public ELBODICMKDE ELBODICMKDE;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E4E0", Offset = "0x6E1CEE0", VA = "0x186E1E4E0")]
			public BFLDAGDKBIB(EMDNAJFOAMA KCELHEPBJBF, GameObject OHKJKAPKDDL, RenderTexture IAJEILDCCAB, ImposterRenderConfig FOADDELBOEA, ELBODICMKDE GLLIGEFOBFP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static PIIGHBDKEIF<BFLDAGDKBIB, RenderTexture> BMPOHBOLJJB;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly List<BFLDAGDKBIB> PAANJEIEIIC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int POMIMFDLFNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6E1F390", Offset = "0x6E1DD90", VA = "0x186E1F390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F4B0", Offset = "0x6E1DEB0", VA = "0x186E1F4B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LKBEHKNIHFM, RenderTexture IAJEILDCCAB, ImposterRenderConfig HJPIJKAMNJE, ELBODICMKDE GLLIGEFOBFP, CancellationToken PPLDCJFFMEP, bool EKNFOHMLOIG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EEE0", Offset = "0x6E1D8E0", VA = "0x186E1EEE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F420", Offset = "0x6E1DE20", VA = "0x186E1F420", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F0F0", Offset = "0x6E1DAF0", VA = "0x186E1F0F0")]
		private static Task<RenderTexture> DPCNCFANNJF(BFLDAGDKBIB DPHFKGGLKHB, CancellationToken PPLDCJFFMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F8B0", Offset = "0x6E1E2B0", VA = "0x186E1F8B0")]
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

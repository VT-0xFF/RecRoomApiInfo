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
	private readonly struct PJCOHNLKBKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly HPCIPFGOJFF PPLKJFGCLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string AMLIJCHMEGJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
		public PJCOHNLKBKO(HPCIPFGOJFF FLGKPEDDINP, string CPIBLBNONOO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ABHBFNAGOKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public PJCOHNLKBKO queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5E30", Offset = "0x5DF4C30", VA = "0x185DF5E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF61D0", Offset = "0x5DF4FD0", VA = "0x185DF61D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider EDKGOCNEFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OKPDOKOKFPI<PJCOHNLKBKO, GameObject> ELJKNADNICH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BAGOPHMAIFN DJEJNFMIJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x770C70", Offset = "0x76FA70", VA = "0x180770C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OKPDOKOKFPI<PJCOHNLKBKO, GameObject> GCMMHHFOFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6FB0", Offset = "0x5DF5DB0", VA = "0x185DF6FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int LGCDIPJHPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6E40", Offset = "0x5DF5C40", VA = "0x185DF6E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6D80", Offset = "0x5DF5B80", VA = "0x185DF6D80", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DF72F0", Offset = "0x5DF60F0", VA = "0x185DF72F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6E90", Offset = "0x5DF5C90", VA = "0x185DF6E90")]
	[AsyncStateMachine(typeof(ABHBFNAGOKN))]
	private Task<GameObject> KICANGNEGKG(PJCOHNLKBKO PGICHLNDANF, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7110", Offset = "0x5DF5F10", VA = "0x185DF7110")]
	public Task<GameObject> LoadItemAsync(HPCIPFGOJFF FLGKPEDDINP, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7360", Offset = "0x5DF6160", VA = "0x185DF7360")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GLGKEFALCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HPCIPFGOJFF LNBNOCLKALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HMMNIADHICM;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77D1D0", Offset = "0x77BFD0", VA = "0x18077D1D0")]
		public GLGKEFALCBA(HPCIPFGOJFF FNPMJANEBMD, Texture PMHKBPCFOHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PIOAJONCDFP
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
	private class OGIIEALCNAD : ENDMHFEHIBD<Texture>, GNJDEICEPMH, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct LMAMGAEDOBN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public OGIIEALCNAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5DFBFB0", Offset = "0x5DFADB0", VA = "0x185DFBFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5DFC7C0", Offset = "0x5DFB5C0", VA = "0x185DFC7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly HPCIPFGOJFF FNPMJANEBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture BHMOOKDHJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig FKPKKILFGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken ELPOPHCEGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject HDHOINMMMOC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HIIDJBNNIDE<Texture> LIFGIPKKMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DFCA50", Offset = "0x5DFB850", VA = "0x185DFCA50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> EIFMLFKMLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCAB0", Offset = "0x5DFB8B0", VA = "0x185DFCAB0")]
		public OGIIEALCNAD(HPCIPFGOJFF FNPMJANEBMD, RenderTexture BHMOOKDHJDP, ImposterRenderConfig FKPKKILFGLJ, CancellationToken ELPOPHCEGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC960", Offset = "0x5DFB760", VA = "0x185DFC960")]
		[AsyncStateMachine(typeof(LMAMGAEDOBN))]
		private Task<Texture> JBMMMLOHBOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC8D0", Offset = "0x5DFB6D0", VA = "0x185DFC8D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC8E0", Offset = "0x5DFB6E0", VA = "0x185DFC8E0")]
		private static void GEINANIDKOD(GameObject HDHOINMMMOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JBPFGADCOKI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5DFB810", Offset = "0x5DFA610", VA = "0x185DFB810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8A0", Offset = "0x8BE6A0", VA = "0x1808BF8A0", Slot = "5")]
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
	[EHGCIBCPLHN(CDIJBINDLCN.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private PIOAJONCDFP size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[NFBFIODBAEO("size", PIOAJONCDFP.Custom)]
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
	private static int JANMPMHJKMO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture IDLKEJACPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private IIFHHPNMFHH<GameObject> JBKIBOPJJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NADEPMJLGPK FIIGGOMOABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource MHPFKGBLOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ENDMHFEHIBD<Texture> GGBKLBHKLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private HPCIPFGOJFF AKIIFEKFNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture HCLFMKAFOHI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LPJNAAENGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB310", Offset = "0x5DFA110", VA = "0x185DFB310")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB360", Offset = "0x5DFA160", VA = "0x185DFB360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PEEDBAHKLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAB50", Offset = "0x5DF9950", VA = "0x185DFAB50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x772BF0", Offset = "0x7719F0", VA = "0x180772BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private HPCIPFGOJFF LNBNOCLKALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x773C10", Offset = "0x772A10", VA = "0x180773C10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAD80", Offset = "0x5DF9B80", VA = "0x185DFAD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool MKDFFLEHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4FC6680", Offset = "0x4FC5480", VA = "0x184FC6680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int AACPDJBKJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA900", Offset = "0x5DF9700", VA = "0x185DFA900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA9A0", Offset = "0x5DF97A0", VA = "0x185DFA9A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAEE0", Offset = "0x5DF9CE0", VA = "0x185DFAEE0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAD00", Offset = "0x5DF9B00", VA = "0x185DFAD00")]
	private void KLMPGKPBOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB230", Offset = "0x5DFA030", VA = "0x185DFB230")]
	public void Set(HPCIPFGOJFF MCCCNONBENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB1E0", Offset = "0x5DF9FE0", VA = "0x185DFB1E0")]
	public void Set(Texture PMHKBPCFOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB1F0", Offset = "0x5DF9FF0", VA = "0x185DFB1F0")]
	public void Set(GLGKEFALCBA PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA9B0", Offset = "0x5DF97B0", VA = "0x185DFA9B0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAFE0", Offset = "0x5DF9DE0", VA = "0x185DFAFE0")]
	public void SetInternal(HPCIPFGOJFF MCCCNONBENL, [Optional] Texture CLDKKEDBEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAFD0", Offset = "0x5DF9DD0", VA = "0x185DFAFD0")]
	public void SetCustomSize(int KMAGEDPJKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x779D80", Offset = "0x778B80", VA = "0x180779D80")]
	public void SetAntiAliasing(int MBPPPOKPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA9C0", Offset = "0x5DF97C0", VA = "0x185DFA9C0")]
	[AsyncStateMachine(typeof(JBPFGADCOKI))]
	private void FKMLELFFJKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAA70", Offset = "0x5DF9870", VA = "0x185DFAA70")]
	private void IOHGIEJGMKB(Texture PMHKBPCFOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB290", Offset = "0x5DFA090", VA = "0x185DFB290")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, PCAOJAMMNIA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float EENFGMCDBIK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "4")]
	public void PrepareImposter(HMCHIOOLMEH CNCKHACNADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA8C0", Offset = "0x5DF96C0", VA = "0x185DFA8C0")]
	public void SetReferencePoint(Vector3 EHFMGFPLNPD, Quaternion GBLLLKBIFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA6C0", Offset = "0x5DF94C0", VA = "0x185DFA6C0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA8A0", Offset = "0x5DF96A0", VA = "0x185DFA8A0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1334020", Offset = "0x1332E20", VA = "0x181334020")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HLCMOJMLLFD
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static HLCMOJMLLFD BOHEBDBLKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float ILPAEFKNNHF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x20059B0", Offset = "0x20047B0", VA = "0x1820059B0")]
	public HLCMOJMLLFD(float LCAFBGJLLCE)
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
		[EHGCIBCPLHN(CDIJBINDLCN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int HBOPEMDFHFJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MCIIBPOIAFK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> DHIHEDNHFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool JAMCDEAFENE;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB540", Offset = "0x5DFA340", VA = "0x185DFB540")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB440", Offset = "0x5DFA240", VA = "0x185DFB440")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB780", Offset = "0x5DFA580", VA = "0x185DFB780")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HPCIPFGOJFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string LJHAPONFCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HLCMOJMLLFD HLCMOJMLLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AGCCBIGLMFJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> JIBNIDNENNG(CancellationToken ELPOPHCEGNN);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LFNCBKOIDGD(HPCIPFGOJFF LCIDHBCOPEO);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGDIPMDJFEG();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HOGDFDEOPIG();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HKNKPLEPCBL([Out] ENDMHFEHIBD<Texture> HCKADOFDNNO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BNLLBABMMHO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6240", Offset = "0x5DF5040", VA = "0x185DF6240")]
	public static bool IEMIJDPOCAK(HPCIPFGOJFF EALCPNJGCKB, HPCIPFGOJFF EHHHHGFLEAB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, PCAOJAMMNIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6330", Offset = "0x5DF5130", VA = "0x185DF6330", Slot = "4")]
		public void PrepareImposter(HMCHIOOLMEH CNCKHACNADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PCAOJAMMNIA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HMCHIOOLMEH CNCKHACNADC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IBKJKPMKLPO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> OONMIDOLFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> OBPGMHODIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BAGOPHMAIFN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject OJPLENFJKHB(GameObject NPFEMNDPOFF, Transform BMNEKBHDGLJ, bool JJBHBGAGAEF = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T OJPLENFJKHB<T>(T NPFEMNDPOFF, Transform BMNEKBHDGLJ, bool JJBHBGAGAEF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T OJPLENFJKHB<T>(GameObject NPFEMNDPOFF, Transform BMNEKBHDGLJ, bool JJBHBGAGAEF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject OJPLENFJKHB(GameObject NPFEMNDPOFF, Transform BMNEKBHDGLJ, HMCHIOOLMEH CNCKHACNADC, bool JJBHBGAGAEF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IHDHCFMGGIB : IDisposable, BAGOPHMAIFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> GKKKMLEIDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> NEIFEBCDHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform HBMCKEPEOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> FIOPCGDBFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> IMDAPOGJNLJ;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9AE0", Offset = "0x5DF88E0", VA = "0x185DF9AE0")]
	[IBKPEPPEMNJ(MIBJABCBNEH.None)]
	public static void GLHDCMGJMLB(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9F80", Offset = "0x5DF8D80", VA = "0x185DF9F80")]
	[Preserve]
	public IHDHCFMGGIB([HOHGLGKGFHE(null)] IBKJKPMKLPO FADNPJCBLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9A00", Offset = "0x5DF8800", VA = "0x185DF9A00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9DE0", Offset = "0x5DF8BE0", VA = "0x185DF9DE0", Slot = "5")]
	public GameObject OJPLENFJKHB(GameObject NPFEMNDPOFF, Transform BMNEKBHDGLJ, bool JJBHBGAGAEF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x251EA60", Offset = "0x251D860", VA = "0x18251EA60", Slot = "6")]
	public T OJPLENFJKHB<T>(T NPFEMNDPOFF, Transform BMNEKBHDGLJ, bool JJBHBGAGAEF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x251EAD0", Offset = "0x251D8D0", VA = "0x18251EAD0", Slot = "7")]
	public T OJPLENFJKHB<T>(GameObject NPFEMNDPOFF, Transform BMNEKBHDGLJ, bool JJBHBGAGAEF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9D50", Offset = "0x5DF8B50", VA = "0x185DF9D50", Slot = "8")]
	public GameObject OJPLENFJKHB(GameObject NPFEMNDPOFF, Transform BMNEKBHDGLJ, HMCHIOOLMEH CNCKHACNADC, bool JJBHBGAGAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x251EB00", Offset = "0x251D900", VA = "0x18251EB00", Slot = "9")]
	public T OJPLENFJKHB<T>(GameObject NPFEMNDPOFF, Transform BMNEKBHDGLJ, HMCHIOOLMEH CNCKHACNADC, bool JJBHBGAGAEF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x251EB40", Offset = "0x251D940", VA = "0x18251EB40")]
	private T OJPLENFJKHB<T>(GameObject NPFEMNDPOFF, Transform BMNEKBHDGLJ, HMCHIOOLMEH CNCKHACNADC, bool JJBHBGAGAEF, [Out] GameObject PHMGMPLMMMK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x251F0B0", Offset = "0x251DEB0", VA = "0x18251F0B0")]
	private T PMHKADMDPBF<T>(GameObject CJHJDJNKIGF, HMCHIOOLMEH CNCKHACNADC, bool JJBHBGAGAEF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9E70", Offset = "0x5DF8C70", VA = "0x185DF9E70")]
	private void PMHEKLKFDHE(Component FMOHLHFOMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9520", Offset = "0x5DF8320", VA = "0x185DF9520")]
	private void BFNCGMBFICD(Component FMOHLHFOMNJ, HMCHIOOLMEH CNCKHACNADC, bool JJBHBGAGAEF, bool IACMMOAHIFM, [Optional] Type PNFHDGPHNCN, [Optional] Type KENKEFDELPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9BE0", Offset = "0x5DF89E0", VA = "0x185DF9BE0")]
	private void IPDLINKCDKB(GameObject CJHJDJNKIGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HMCHIOOLMEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> BAPJCDMJGJK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25101E0", Offset = "0x250EFE0", VA = "0x1825101E0")]
	public HMCHIOOLMEH CCOBHHAAMMF<T>(T JAJNMAIJGBL)
	{
		return default(HMCHIOOLMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2510910", Offset = "0x250F710", VA = "0x182510910")]
	public T HFNEOIKDHBA<T>(T JDDKNLMJJIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2510A20", Offset = "0x250F820", VA = "0x182510A20")]
	public bool PGALEGIIEOF<T>([Out] T JAJNMAIJGBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OKLDNOLGEPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool PIPMBHOKDFH;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xBA4570", Offset = "0xBA3370", VA = "0x180BA4570")]
	public OKLDNOLGEPC(bool BIEBCDEAHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HBDLIOIIGGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool IKJGEJIIJKF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF94D0", Offset = "0x5DF82D0", VA = "0x185DF94D0")]
	public HBDLIOIIGGD(bool JDLHLJIHEKD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, PCAOJAMMNIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCC30", Offset = "0x5DFBA30", VA = "0x185DFCC30", Slot = "4")]
		public void PrepareImposter(HMCHIOOLMEH CNCKHACNADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
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
		public Bounds EMGFDBGHIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5DFA530", Offset = "0x5DF9330", VA = "0x185DFA530")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA4F0", Offset = "0x5DF92F0", VA = "0x185DFA4F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA4B0", Offset = "0x5DF92B0", VA = "0x185DFA4B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA3C0", Offset = "0x5DF91C0", VA = "0x185DFA3C0")]
		private void IDHHPCGCKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76DFF0", VA = "0x18076F1F0")]
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
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5DFC840", Offset = "0x5DFB640", VA = "0x185DFC840")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5DFC830", Offset = "0x5DFB630", VA = "0x185DFC830")]
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
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
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
		[Cpp2IlInjected.Address(RVA = "0x5DFB3E0", Offset = "0x5DFA1E0", VA = "0x185DFB3E0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GDOCIDEJAKA
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> HNMCKNBACOI;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 COGEHKJDBHL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 GPHDONDBFLP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera JKNMGIKOJEC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> BBOOCEGKEAH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> CFDPMBLLKBL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode EIEEGDNBCMD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color IMCCHNHCCKK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color IAGFICACOJI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color KDCGCOEEJLI;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap JICMNMKIHPM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool HCLOOPMGHIA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera FGIHIMABDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5DF7970", Offset = "0x5DF6770", VA = "0x185DF7970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8EA0", Offset = "0x5DF7CA0", VA = "0x185DF8EA0")]
	public static void KJDNCHHPNIG(Vector3 AMIABLCCCMK, Quaternion BPINLMPBCDP, ImposterRenderConfig NONMANIJEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF73A0", Offset = "0x5DF61A0", VA = "0x185DF73A0")]
	private static void BCCLFLLHMMD(Vector3 AMIABLCCCMK, Quaternion BPINLMPBCDP, URPLight AJCKMPMNMAK, ImposterRenderConfig.LightConfig FBDJDHMNKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7FB0", Offset = "0x5DF6DB0", VA = "0x185DF7FB0")]
	public static void FCDGHKAABHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7C30", Offset = "0x5DF6A30", VA = "0x185DF7C30")]
	private static void EKBPILKICPE(int OENNNMDFBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8CE0", Offset = "0x5DF7AE0", VA = "0x185DF8CE0")]
	public static void KFAJGPIHBDD(ImposterRenderConfig NONMANIJEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8090", Offset = "0x5DF6E90", VA = "0x185DF8090")]
	public static void GIILIEPLMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9110", Offset = "0x5DF7F10", VA = "0x185DF9110")]
	public static void MNJMKOIEBMI(GameObject APPLIJNFNDC, RenderTexture BHMOOKDHJDP, ImposterRenderConfig NONMANIJEDD, HLCMOJMLLFD FDEAPFIDKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8180", Offset = "0x5DF6F80", VA = "0x185DF8180")]
	private static void JGADLCLKCKD(GameObject APPLIJNFNDC, RenderTexture BHMOOKDHJDP, ImposterRenderConfig NONMANIJEDD, HLCMOJMLLFD FDEAPFIDKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DF76D0", Offset = "0x5DF64D0", VA = "0x185DF76D0")]
	private static void BPPJMPJKBML(GameObject APPLIJNFNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8760", Offset = "0x5DF7560", VA = "0x185DF8760")]
	public static void JNODDMNDPMN(GameObject NPFEMNDPOFF, Vector3 PHMDAPNDEJI, Vector3 CPNDOLPPKED, float LKBOKDGBBCL, HLCMOJMLLFD FDEAPFIDKPA, [Out] Vector3 PMFCOAJHMFC, [Out] Quaternion IHEAJPHHLKH, [Out] float HLMJFEPMHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7B80", Offset = "0x5DF6980", VA = "0x185DF7B80")]
	public static RenderTexture ECFBBBBFJEM(int DBGLJKBGOEL, int MIKKOCNOFKH, RenderTextureFormat NFCLHEIIJBK = RenderTextureFormat.ARGB32)
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
		public struct NAOHBFEFJMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public FPFMKNGKADD GPFIADJJCDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject MMMEPDPMNPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture PEEDBAHKLFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig MLFHCAHLHBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public HLCMOJMLLFD HLCMOJMLLFD;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5DFC860", Offset = "0x5DFB660", VA = "0x185DFC860")]
			public NAOHBFEFJMC(FPFMKNGKADD CBJJPLNLOBG, GameObject LDNOJFNHFDJ, RenderTexture BHMOOKDHJDP, ImposterRenderConfig FKPKKILFGLJ, HLCMOJMLLFD FDEAPFIDKPA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static OKPDOKOKFPI<NAOHBFEFJMC, RenderTexture> EFPKBFNEEKC;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<NAOHBFEFJMC> KHIINHDPFEK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int HJKHBOFDOFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5DF6810", Offset = "0x5DF5610", VA = "0x185DF6810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6920", Offset = "0x5DF5720", VA = "0x185DF6920")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject APPLIJNFNDC, RenderTexture BHMOOKDHJDP, ImposterRenderConfig NONMANIJEDD, HLCMOJMLLFD FDEAPFIDKPA, CancellationToken ELPOPHCEGNN, bool EDBEFDJLKCM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6480", Offset = "0x5DF5280", VA = "0x185DF6480", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6880", Offset = "0x5DF5680", VA = "0x185DF6880", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6670", Offset = "0x5DF5470", VA = "0x185DF6670")]
		private static Task<RenderTexture> FFCIMIBNDGH(NAOHBFEFJMC CEOHHDNFODB, CancellationToken ELPOPHCEGNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6D40", Offset = "0x5DF5B40", VA = "0x185DF6D40")]
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

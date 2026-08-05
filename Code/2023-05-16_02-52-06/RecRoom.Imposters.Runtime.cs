using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
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
	private readonly struct NKONJIONJJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BHAOEGFGFKI HPCNKDEGPIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BAPPBPLIODL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x809110", Offset = "0x807F10", VA = "0x180809110")]
		public NKONJIONJJG(BHAOEGFGFKI MGHCGGIDFNG, string AEHIGCBGBMA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KKLNGBKPEJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NKONJIONJJG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69EE570", Offset = "0x69ED370", VA = "0x1869EE570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69EE8B0", Offset = "0x69ED6B0", VA = "0x1869EE8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider KMOGECJLGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::EOFLJFJCCMH<NKONJIONJJG, GameObject> KMBGLBFPPAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NBJEHDCCDBI OHEKKFOOEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::EOFLJFJCCMH<NKONJIONJJG, GameObject> IKLLBABNJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69EBC10", Offset = "0x69EAA10", VA = "0x1869EBC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KMDMONEEHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69EBD70", Offset = "0x69EAB70", VA = "0x1869EBD70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69EBB60", Offset = "0x69EA960", VA = "0x1869EBB60", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69EBF90", Offset = "0x69EAD90", VA = "0x1869EBF90", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69EBA10", Offset = "0x69EA810", VA = "0x1869EBA10")]
	[AsyncStateMachine(typeof(KKLNGBKPEJA))]
	private Task<GameObject> AKIPINKADMJ(NKONJIONJJG JAKOCLFCJED, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69EBDC0", Offset = "0x69EABC0", VA = "0x1869EBDC0")]
	public Task<GameObject> LoadItemAsync(BHAOEGFGFKI MGHCGGIDFNG, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69EC000", Offset = "0x69EAE00", VA = "0x1869EC000")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BGJAOLFIAGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BHAOEGFGFKI HMDCENKNEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture AILIAHAEHJP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7406E0", Offset = "0x73F4E0", VA = "0x1807406E0")]
		public BGJAOLFIAGO(BHAOEGFGFKI KFEOGEMIAGE, Texture HICKPGGKAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ACKDDGDAECF
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class CGJEIEECECA : global::BLENMGIJHFH<Texture>, KMLDHBEBAEG, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct ONMEEIDPIBN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CGJEIEECECA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69EEA20", Offset = "0x69ED820", VA = "0x1869EEA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69EF120", Offset = "0x69EDF20", VA = "0x1869EF120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly BHAOEGFGFKI KFEOGEMIAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture MHGCFGLEIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig MJEMPCJCNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken NBLKBHANAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject BFLKAADPIEG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PONAFBMJJFC NLIAMNCLBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69EAD90", Offset = "0x69E9B90", VA = "0x1869EAD90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::OOLBMJPBBIG<Texture> ICPDCDPBMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x69EAB80", Offset = "0x69E9980", VA = "0x1869EAB80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task KNBECMBFIOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> OOIHGHGIBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69EADA0", Offset = "0x69E9BA0", VA = "0x1869EADA0")]
		public CGJEIEECECA(BHAOEGFGFKI KFEOGEMIAGE, RenderTexture MHGCFGLEIOE, ImposterRenderConfig MJEMPCJCNKF, CancellationToken NBLKBHANAPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69EAC70", Offset = "0x69E9A70", VA = "0x1869EAC70")]
		[AsyncStateMachine(typeof(ONMEEIDPIBN))]
		private Task<Texture> HBKEBMFFGNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69EAC60", Offset = "0x69E9A60", VA = "0x1869EAC60", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69EABD0", Offset = "0x69E99D0", VA = "0x1869EABD0")]
		private static void BBEAGBDECCF(GameObject BFLKAADPIEG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BAIJHCAGMMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69EA3F0", Offset = "0x69E91F0", VA = "0x1869EA3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x74B100", Offset = "0x749F00", VA = "0x18074B100", Slot = "5")]
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
	[LJGEGNIDGLA(DIBFHMICKPK.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private ACKDDGDAECF size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[JHKJJNMIAJO("size", 0)]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private RenderTexture IJGGNBMGLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::HBPFDMEHDHH<GameObject> ABLCNHKKIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BMBBAPOFAOP GNKDOPBMPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource BCHDMIKMMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::BLENMGIJHFH<Texture> IDKBHNDIDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private BHAOEGFGFKI AOIJBAIBHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture OGOCDHLKOKB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture GOENEAELPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69ED390", Offset = "0x69EC190", VA = "0x1869ED390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x748BD0", Offset = "0x7479D0", VA = "0x180748BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private BHAOEGFGFKI HMDCENKNEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x757910", Offset = "0x756710", VA = "0x180757910")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69ED220", Offset = "0x69EC020", VA = "0x1869ED220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool OLELJEPGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x92D5F0", Offset = "0x92C3F0", VA = "0x18092D5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int MIPFLAECOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69ED380", Offset = "0x69EC180", VA = "0x1869ED380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69ED210", Offset = "0x69EC010", VA = "0x1869ED210")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69ED750", Offset = "0x69EC550", VA = "0x1869ED750")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69ED500", Offset = "0x69EC300", VA = "0x1869ED500")]
	private void GEFFGDIMKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69EDA70", Offset = "0x69EC870", VA = "0x1869EDA70")]
	public void Set(BHAOEGFGFKI EELJGCHEPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69EDAC0", Offset = "0x69EC8C0", VA = "0x1869EDAC0")]
	public void Set(Texture HICKPGGKAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69EDA80", Offset = "0x69EC880", VA = "0x1869EDA80")]
	public void Set(BGJAOLFIAGO MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69ED370", Offset = "0x69EC170", VA = "0x1869ED370")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69ED850", Offset = "0x69EC650", VA = "0x1869ED850")]
	public void SetInternal(BHAOEGFGFKI EELJGCHEPPL, [Optional] Texture LNGNCAJHHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69ED840", Offset = "0x69EC640", VA = "0x1869ED840")]
	public void SetCustomSize(int JIOBEAAEAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8710", Offset = "0x7A7510", VA = "0x1807A8710")]
	public void SetAntiAliasing(int KPLNMBLMKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69ED590", Offset = "0x69EC390", VA = "0x1869ED590")]
	[AsyncStateMachine(typeof(BAIJHCAGMMF))]
	private void JOHAABOJFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69ED660", Offset = "0x69EC460", VA = "0x1869ED660")]
	private void MKBFNNHFPME(Texture HICKPGGKAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69EDAD0", Offset = "0x69EC8D0", VA = "0x1869EDAD0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, NGMLLKHGHKG
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float DLBBBDAOBAE = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
	public void PrepareImposter(PFAIOCPNFDP DNHNNDBCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69ED1D0", Offset = "0x69EBFD0", VA = "0x1869ED1D0")]
	public void SetReferencePoint(Vector3 LNLPNIDIPMD, Quaternion BBEANHLOOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69ED040", Offset = "0x69EBE40", VA = "0x1869ED040")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69ED1A0", Offset = "0x69EBFA0", VA = "0x1869ED1A0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x139F4D0", Offset = "0x139E2D0", VA = "0x18139F4D0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DKMCGBENCGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static DKMCGBENCGJ GHCBNHDBMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float IAMLLMMNNGM;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x31E0100", Offset = "0x31DEF00", VA = "0x1831E0100")]
	public DKMCGBENCGJ(float JFJMDMKFMIK)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[LJGEGNIDGLA(DIBFHMICKPK.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int LFJOIPFHDIC = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int NMJLEGMFJIM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> AACAIBFBPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool DKJPCGPOLNM;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69EDC80", Offset = "0x69ECA80", VA = "0x1869EDC80")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69EDB90", Offset = "0x69EC990", VA = "0x1869EDB90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69EDEC0", Offset = "0x69ECCC0", VA = "0x1869EDEC0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BHAOEGFGFKI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string AOLKIHGIEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DKMCGBENCGJ DKMCGBENCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NKFGMHCFKGB;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> IBPGLBBGLEI(CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCBPGBNAFJP(BHAOEGFGFKI IDBPJJAKCBN);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHJKAGKEBGA();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DINIHNPKMEA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KLODGMOOOGP(out global::BLENMGIJHFH<Texture> JJIDCDLKIIA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LLKPEOFOKKL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69EE910", Offset = "0x69ED710", VA = "0x1869EE910")]
	public static bool JEPFEDJKDBC(BHAOEGFGFKI NGAFPONGLAK, BHAOEGFGFKI KPGDBFIJICK)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, NGMLLKHGHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69EAF40", Offset = "0x69E9D40", VA = "0x1869EAF40", Slot = "4")]
		public void PrepareImposter(PFAIOCPNFDP DNHNNDBCPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NGMLLKHGHKG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PFAIOCPNFDP DNHNNDBCPLH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GEELIIJKPDG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> LPKKMGFDAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> HMLODEDKNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NBJEHDCCDBI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAJIFMEALBO(params Type[] LFNDHOPEOFJ);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJCOKGNHGJC(params Type[] LFNDHOPEOFJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject CIJHBJBFJAL(GameObject PEINAPABAGG, Transform GANAMHNGMGO, bool NCIFPFBPHGD = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T CIJHBJBFJAL<T>(T PEINAPABAGG, Transform GANAMHNGMGO, bool NCIFPFBPHGD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T CIJHBJBFJAL<T>(GameObject PEINAPABAGG, Transform GANAMHNGMGO, bool NCIFPFBPHGD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject CIJHBJBFJAL(GameObject PEINAPABAGG, Transform GANAMHNGMGO, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T CIJHBJBFJAL<T>(GameObject PEINAPABAGG, Transform GANAMHNGMGO, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T CIJHBJBFJAL<T>(T PEINAPABAGG, Transform GANAMHNGMGO, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GLLJCEDNCHB : IDisposable, NBJEHDCCDBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> CLLCEMPKPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> NCABGCCBGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform DEFJGALFGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> OLFDAPFCAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ALOBLLHGPNH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69EC830", Offset = "0x69EB630", VA = "0x1869EC830")]
	[CFDOMFEMHNO(ANAFFCEINAM.None)]
	public static void HGNLLPENNMP(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69ECC00", Offset = "0x69EBA00", VA = "0x1869ECC00")]
	[Preserve]
	public GLLJCEDNCHB([HDMGOABMPFL(null)] GEELIIJKPDG FFGIBNJHFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69EC730", Offset = "0x69EB530", VA = "0x1869EC730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69EC070", Offset = "0x69EAE70", VA = "0x1869EC070", Slot = "5")]
	public void AAJIFMEALBO(params Type[] LFNDHOPEOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69ECBB0", Offset = "0x69EB9B0", VA = "0x1869ECBB0", Slot = "6")]
	public void LJCOKGNHGJC(params Type[] LFNDHOPEOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69EC150", Offset = "0x69EAF50", VA = "0x1869EC150", Slot = "7")]
	public GameObject CIJHBJBFJAL(GameObject PEINAPABAGG, Transform GANAMHNGMGO, bool NCIFPFBPHGD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2BF0", Offset = "0x2AE19F0", VA = "0x182AE2BF0", Slot = "8")]
	public T CIJHBJBFJAL<T>(T PEINAPABAGG, Transform GANAMHNGMGO, bool NCIFPFBPHGD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2BC0", Offset = "0x2AE19C0", VA = "0x182AE2BC0", Slot = "9")]
	public T CIJHBJBFJAL<T>(GameObject PEINAPABAGG, Transform GANAMHNGMGO, bool NCIFPFBPHGD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69EC0C0", Offset = "0x69EAEC0", VA = "0x1869EC0C0", Slot = "10")]
	public GameObject CIJHBJBFJAL(GameObject PEINAPABAGG, Transform GANAMHNGMGO, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2C60", Offset = "0x2AE1A60", VA = "0x182AE2C60", Slot = "11")]
	public T CIJHBJBFJAL<T>(GameObject PEINAPABAGG, Transform GANAMHNGMGO, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2CB0", Offset = "0x2AE1AB0", VA = "0x182AE2CB0", Slot = "12")]
	public T CIJHBJBFJAL<T>(T PEINAPABAGG, Transform GANAMHNGMGO, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2D40", Offset = "0x2AE1B40", VA = "0x182AE2D40")]
	private T CIJHBJBFJAL<T>(GameObject PEINAPABAGG, Transform GANAMHNGMGO, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD, out GameObject NOOJBEANCGE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3270", Offset = "0x2AE2070", VA = "0x182AE3270")]
	private T NOAOMJAMAMK<T>(GameObject HNLFAAIOFFP, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69ECA80", Offset = "0x69EB880", VA = "0x1869ECA80")]
	private void LJBFLBJKMEO(Component KHJAOGDHEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69EC1E0", Offset = "0x69EAFE0", VA = "0x1869EC1E0")]
	private void CKIACLNJICC(Component KHJAOGDHEIM, PFAIOCPNFDP DNHNNDBCPLH, bool NCIFPFBPHGD, bool PGJOIIFBLJF, [Optional] Type PKMBPGBKAHK, [Optional] Type AAPLCEPOFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69EC920", Offset = "0x69EB720", VA = "0x1869EC920")]
	private void IGGEGMADLDN(GameObject HNLFAAIOFFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PFAIOCPNFDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> LKJAPEPPFJE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27E7F00", Offset = "0x27E6D00", VA = "0x1827E7F00")]
	public PFAIOCPNFDP KKNDJJJFEOO<T>(T GPFMFOMFONC)
	{
		return default(PFAIOCPNFDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27E7560", Offset = "0x27E6360", VA = "0x1827E7560")]
	public T BANNGLOAJDI<T>(T HPJBCMEILDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x27E7620", Offset = "0x27E6420", VA = "0x1827E7620")]
	public bool EHAPPLAHJDF<T>(out T GPFMFOMFONC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NCEGELFGKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool MECDEHEKGPO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xEEFE50", Offset = "0xEEEC50", VA = "0x180EEFE50")]
	public NCEGELFGKCM(bool LFKHJGDPOOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LAGHEJEJLOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool BGFNOHAJIMC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69EE900", Offset = "0x69ED700", VA = "0x1869EE900")]
	public LAGHEJEJLOE(bool IMMOAKGLBOE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, NGMLLKHGHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69F12F0", Offset = "0x69F00F0", VA = "0x1869F12F0", Slot = "4")]
		public void PrepareImposter(PFAIOCPNFDP DNHNNDBCPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x69EEA00", Offset = "0x69ED800", VA = "0x1869EEA00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x69EE9F0", Offset = "0x69ED7F0", VA = "0x1869EE9F0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69EDB50", Offset = "0x69EC950", VA = "0x1869EDB50")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PJPDDFNMFLO
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> ADDMCJEJJMB;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 GGGFGEBIJOI;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 BAGBIKKLENL;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera CLLPMKJGGIL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string DMCJFGBJHAN = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const EFKLPCCNKEO AJNANIFCAGI = EFKLPCCNKEO.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> LJEAIADBAEA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode LHACPEEINGL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color JNHFEDNDEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color LMIDDBHODJN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color MMIAIPELFPI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap EGPEABPAFAL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool FOMMGGEKIHG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera PNBJHDFHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69EF340", Offset = "0x69EE140", VA = "0x1869EF340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69F0860", Offset = "0x69EF660", VA = "0x1869F0860")]
	public static void MGPLGMMPFAM(Vector3 IFJIJJOJOHI, Quaternion PNOIGONJNGO, ImposterRenderConfig EPAKNKOMMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69F0550", Offset = "0x69EF350", VA = "0x1869F0550")]
	private static void LJEKAMMIAFP(Vector3 IFJIJJOJOHI, Quaternion PNOIGONJNGO, URPLight NGPENOINCEH, ImposterRenderConfig.LightConfig HALHAAKKNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69EF7A0", Offset = "0x69EE5A0", VA = "0x1869EF7A0")]
	public static void COIPADBMIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69F0AE0", Offset = "0x69EF8E0", VA = "0x1869F0AE0")]
	private static void NDBCBCGGGBH(int LELBPCKCOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69F0EB0", Offset = "0x69EFCB0", VA = "0x1869F0EB0")]
	public static void NOHBAIOMOLA(ImposterRenderConfig EPAKNKOMMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69F1030", Offset = "0x69EFE30", VA = "0x1869F1030")]
	public static void PHCEHACCJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69EF170", Offset = "0x69EDF70", VA = "0x1869EF170")]
	public static void ADJOJOGFJAC(GameObject HOMPGIPPCGO, RenderTexture MHGCFGLEIOE, ImposterRenderConfig EPAKNKOMMFI, DKMCGBENCGJ CGEEDBBHPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69EFD80", Offset = "0x69EEB80", VA = "0x1869EFD80")]
	private static void GKAMIKEOHKF(GameObject HOMPGIPPCGO, RenderTexture MHGCFGLEIOE, ImposterRenderConfig EPAKNKOMMFI, DKMCGBENCGJ CGEEDBBHPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69EFA30", Offset = "0x69EE830", VA = "0x1869EFA30")]
	private static void EOPILINGBMI(GameObject HOMPGIPPCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69EF890", Offset = "0x69EE690", VA = "0x1869EF890")]
	public static void EIEFEFHGCBD(List<Renderer> DFEOOJDEBIC, List<Material> ACIKMHBEACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69F0280", Offset = "0x69EF080", VA = "0x1869F0280")]
	public static void HEODCMDDLBG(GameObject PEINAPABAGG, Vector3 LNKHDAHLEFP, Vector3 JGGAHIBJJEL, float AOCOBGFDEJE, DKMCGBENCGJ CGEEDBBHPPN, out Vector3 FBBGBPAGCKG, out Quaternion MGDBPIGHACB, out float EJOJPNAIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69EFCE0", Offset = "0x69EEAE0", VA = "0x1869EFCE0")]
	public static RenderTexture FFJKMDJOBCE(int NMEFFJNNPPL, int FPELGIFOMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69EF570", Offset = "0x69EE370", VA = "0x1869EF570")]
	public static void BHGDFAIKNAM()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct PKEBMECCIHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public OOJANPILAPP GBJLGGKCNCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject GKFLHEKOGCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture GOENEAELPMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig MNABCICHBFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public DKMCGBENCGJ DKMCGBENCGJ;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x69F1280", Offset = "0x69F0080", VA = "0x1869F1280")]
			public PKEBMECCIHD(OOJANPILAPP MDMLEAMEPOH, GameObject AFHAKEEMNJC, RenderTexture MHGCFGLEIOE, ImposterRenderConfig MJEMPCJCNKF, DKMCGBENCGJ CGEEDBBHPPN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::EOFLJFJCCMH<PKEBMECCIHD, RenderTexture> EABLIJCKIHH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<PKEBMECCIHD> GOEBDPOGGLN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int PCNGLPAJKIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x69EB2D0", Offset = "0x69EA0D0", VA = "0x1869EB2D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69EB5B0", Offset = "0x69EA3B0", VA = "0x1869EB5B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject HOMPGIPPCGO, RenderTexture MHGCFGLEIOE, ImposterRenderConfig EPAKNKOMMFI, DKMCGBENCGJ CGEEDBBHPPN, CancellationToken NBLKBHANAPP, bool IMGIMKKGNFN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69EB0E0", Offset = "0x69E9EE0", VA = "0x1869EB0E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69EB510", Offset = "0x69EA310", VA = "0x1869EB510", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69EB340", Offset = "0x69EA140", VA = "0x1869EB340")]
		private static Task<RenderTexture> NEOEAIGGKNP(PKEBMECCIHD FKPGDLMCHEA, CancellationToken NBLKBHANAPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69EB9A0", Offset = "0x69EA7A0", VA = "0x1869EB9A0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69EE290", Offset = "0x69ED090", VA = "0x1869EE290")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69EDF40", Offset = "0x69ECD40", VA = "0x1869EDF40")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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

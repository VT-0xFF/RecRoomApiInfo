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
public class ImposterPreviewCustomFraming : MonoBehaviour, HLMFPEIHCPC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float JPOICJKKBKL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "4")]
	public void PrepareImposter(GIGFBDAKNKF IHHAIAFPENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x15EED10", Offset = "0x15EE110", VA = "0x1815EED10")]
	public void SetReferencePoint(Vector3 NADLKJKLONK, Quaternion OGPILFJIIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x15EEB80", Offset = "0x15EDF80", VA = "0x1815EEB80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15EECE0", Offset = "0x15EE0E0", VA = "0x1815EECE0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15EED50", Offset = "0x15EE150", VA = "0x1815EED50")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class BAFCAONPPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public ELBLEHDKMED POHGGCOFFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture BHIICGCOLHB;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8550C0", Offset = "0x8544C0", VA = "0x1808550C0")]
		public BAFCAONPPCM(ELBLEHDKMED AOPHPAFMAAF, Texture HMKLFIBKCHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum HJLAHBCIJMN
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
	private class MJDADCBOGLB : global::KFBENPHJFEN<Texture>, KBEAHKJNPMN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HDHKDFIIEAK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public MJDADCBOGLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private GameObject <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public HDHKDFIIEAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x15ED400", Offset = "0x15EC800", VA = "0x1815ED400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ELBLEHDKMED AOPHPAFMAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture MDJHAOOHGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig GLABHKPPDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken EMJFDFLJKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject MAMBODNPDDG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private FKADHPEOOEO DBGBIJPFDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x15F22A0", Offset = "0x15F16A0", VA = "0x1815F22A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public global::CBFHNKNAJIN<Texture> FMLDFLIAFEK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x15F2250", Offset = "0x15F1650", VA = "0x1815F2250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Task ACKFFHOOGGF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<Texture> NOLFHMGACNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x15F22B0", Offset = "0x15F16B0", VA = "0x1815F22B0")]
		public MJDADCBOGLB(ELBLEHDKMED AOPHPAFMAAF, RenderTexture MDJHAOOHGFG, ImposterRenderConfig GLABHKPPDCN, CancellationToken EMJFDFLJKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x15F2060", Offset = "0x15F1460", VA = "0x1815F2060")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HDHKDFIIEAK))]
		private Task<Texture> ACPAJGJPBNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x15F21B0", Offset = "0x15F15B0", VA = "0x1815F21B0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x15F21C0", Offset = "0x15F15C0", VA = "0x1815F21C0")]
		private static void IJAAEKBLHFO(GameObject MAMBODNPDDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OCHHJEBCOML : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OCHHJEBCOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x15F2480", Offset = "0x15F1880", VA = "0x1815F2480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
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
	[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private HJLAHBCIJMN size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[MJNEDKHJIPG("size", 0)]
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
	private RenderTexture MJEODNJADJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private global::PKMDKBEHJNJ<GameObject> EEFMJMPGBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DAPNFHHMCEG NJHMAEOGBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource KJMNKMJBOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private global::KFBENPHJFEN<Texture> IJHHAAABAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ELBLEHDKMED OKIEFJODNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture HANIBGGLCCL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture DBELKFOBGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x15EEE40", Offset = "0x15EE240", VA = "0x1815EEE40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85D520", Offset = "0x85C920", VA = "0x18085D520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ELBLEHDKMED POHGGCOFFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89ED20", Offset = "0x89E120", VA = "0x18089ED20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x15EF0B0", Offset = "0x15EE4B0", VA = "0x1815EF0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FDKHIBOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBA4030", Offset = "0xBA3430", VA = "0x180BA4030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NNJJFNACCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x15EF0A0", Offset = "0x15EE4A0", VA = "0x1815EF0A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x15EED90", Offset = "0x15EE190", VA = "0x1815EED90")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x15EF2E0", Offset = "0x15EE6E0", VA = "0x1815EF2E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x15EEDA0", Offset = "0x15EE1A0", VA = "0x1815EEDA0")]
	private void CJOJKOABPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x15EF650", Offset = "0x15EEA50", VA = "0x1815EF650")]
	public void Set(ELBLEHDKMED GNPAJJDBEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x15EF600", Offset = "0x15EEA00", VA = "0x1815EF600")]
	public void Set(Texture HMKLFIBKCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x15EF610", Offset = "0x15EEA10", VA = "0x1815EF610")]
	public void Set(BAFCAONPPCM EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x15EEE30", Offset = "0x15EE230", VA = "0x1815EEE30")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x15EF3E0", Offset = "0x15EE7E0", VA = "0x1815EF3E0")]
	public void SetInternal(ELBLEHDKMED GNPAJJDBEIF, [Optional] Texture BFBAPBMLEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x15EF3D0", Offset = "0x15EE7D0", VA = "0x1815EF3D0")]
	public void SetCustomSize(int KJLBFBHOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9738E0", Offset = "0x972CE0", VA = "0x1809738E0")]
	public void SetAntiAliasing(int KCHEOKGOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x15EF200", Offset = "0x15EE600", VA = "0x1815EF200")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OCHHJEBCOML))]
	private void MKFAONJAEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x15EEFB0", Offset = "0x15EE3B0", VA = "0x1815EEFB0")]
	private void IJBFDHPOBDD(Texture HMKLFIBKCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x15EF660", Offset = "0x15EEA60", VA = "0x1815EF660")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HKJDBEIEGIC
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static HKJDBEIEGIC EEODDJEPANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float GOLBNHEPJHF;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD78040", Offset = "0xD77440", VA = "0x180D78040")]
	public HKJDBEIEGIC(float FIHLOPFFKPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct MLNFDLKLLPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly ELBLEHDKMED JBMMGLNMBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string GIMPGDCDJIB;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
		public MLNFDLKLLPK(ELBLEHDKMED GHJBNPPNEID, string NFILGCJMNAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JDLLMNKLEBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public MLNFDLKLLPK queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private ELBLEHDKMED <request>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private GameObject <imposter>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GameObject <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JDLLMNKLEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x15EFB10", Offset = "0x15EEF10", VA = "0x1815EFB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider MMEIKNOGDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private global::LGABAFLDHKL<MLNFDLKLLPK, GameObject> NHNIEOIPKDE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KOFFNIKBOAI GABOCBFBAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private global::LGABAFLDHKL<MLNFDLKLLPK, GameObject> EADDDFCOBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x15ECD50", Offset = "0x15EC150", VA = "0x1815ECD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int ANKNMLCNJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x15ED220", Offset = "0x15EC620", VA = "0x1815ED220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x15ECCA0", Offset = "0x15EC0A0", VA = "0x1815ECCA0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x15ED270", Offset = "0x15EC670", VA = "0x1815ED270", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x15ECEB0", Offset = "0x15EC2B0", VA = "0x1815ECEB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDLLMNKLEBB))]
	private Task<GameObject> LOONDDJBEEI(MLNFDLKLLPK EEMBKFAHPPE, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x15ED050", Offset = "0x15EC450", VA = "0x1815ED050")]
	public Task<GameObject> LoadItemAsync(ELBLEHDKMED GHJBNPPNEID, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15ED2E0", Offset = "0x15EC6E0", VA = "0x1815ED2E0")]
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
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int NKPLIMKEFBG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int ACEHDCADELE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> HGNLGPPDALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool LOIOIONEGFM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x15EF840", Offset = "0x15EEC40", VA = "0x1815EF840")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x15EF750", Offset = "0x15EEB50", VA = "0x1815EF750")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x15EFA80", Offset = "0x15EEE80", VA = "0x1815EFA80")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ELBLEHDKMED
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string NEAJKPCNNKN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HKJDBEIEGIC HKJDBEIEGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NJKDGIHBMDN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GCCPHJJMEDM(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HEMFDKICHNE(ELBLEHDKMED CCJMBGJFGLH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLKMNIBGEMD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GIAELHCOFLG();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HEHLGIIPMMH(out global::KFBENPHJFEN<Texture> LOGJLHKKDLK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GHGFAEHAJDM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x15ED320", Offset = "0x15EC720", VA = "0x1815ED320")]
	public static bool LKEGMONCJHG(ELBLEHDKMED JAOEPDLBDCN, ELBLEHDKMED BGLIEFGAAIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JFBKDFPCLCI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HIJFFGJMLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> JFNAMNABLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KOFFNIKBOAI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGAELNKENIC(params Type[] FKOMPPKIBLI);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOKKPENBAHB(params Type[] FKOMPPKIBLI);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject GPCNIIGNBMG(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, bool KGAAGBCGFFM = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T GPCNIIGNBMG<T>(T BLJDINJOMCN, Transform MOHMMJFCOKF, bool KGAAGBCGFFM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T GPCNIIGNBMG<T>(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, bool KGAAGBCGFFM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject GPCNIIGNBMG(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T GPCNIIGNBMG<T>(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T GPCNIIGNBMG<T>(T BLJDINJOMCN, Transform MOHMMJFCOKF, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MBODLCDALHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> JHCPEAPPOAP;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 PDCFPADMIMP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 DJICPHKCBJM;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera NAHEPCGLBIM;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public const string PHLOGEOIJLB = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const HKJEDOAKNOD KDJMFCDCLGN = HKJEDOAKNOD.Water;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly List<Renderer> AGDFODPPKKO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static AmbientMode KOFDPHFGGII;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color JMNOKCCDJNB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Color EGJEGKNCMIF;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Color MHBEMGDJGLC;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Cubemap IOECKLGOGCJ;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static bool GJILOBHPONB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera PCNEBMEBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x15F1500", Offset = "0x15F0900", VA = "0x1815F1500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x15F1280", Offset = "0x15F0680", VA = "0x1815F1280")]
	public static void JAIHIOEKDMF(Vector3 HPOAANBGPEK, Quaternion CAIBGCBLAOJ, ImposterRenderConfig BMCBPCECDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF40", Offset = "0x15EF340", VA = "0x1815EFF40")]
	private static void AKNMBAMHEIK(Vector3 HPOAANBGPEK, Quaternion CAIBGCBLAOJ, URPLight DONMJDIIIFL, ImposterRenderConfig.LightConfig HMKOGFEKFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x15F0490", Offset = "0x15EF890", VA = "0x1815F0490")]
	public static void BLCEPJFMDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x15F1B40", Offset = "0x15F0F40", VA = "0x1815F1B40")]
	private static void PPLHKDGGNBE(int IFIIOEGKEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x15F0A80", Offset = "0x15EFE80", VA = "0x1815F0A80")]
	public static void CJCBJFJNGOB(ImposterRenderConfig BMCBPCECDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x15F0C00", Offset = "0x15F0000", VA = "0x1815F0C00")]
	public static void EOPMPHCDBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x15F1970", Offset = "0x15F0D70", VA = "0x1815F1970")]
	public static void OPADJCINGGH(GameObject GFIJINBOANJ, RenderTexture MDJHAOOHGFG, ImposterRenderConfig BMCBPCECDMD, HKJDBEIEGIC MOCBBEJOAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x15F0580", Offset = "0x15EF980", VA = "0x1815F0580")]
	private static void BNJODEKIHJE(GameObject GFIJINBOANJ, RenderTexture MDJHAOOHGFG, ImposterRenderConfig BMCBPCECDMD, HKJDBEIEGIC MOCBBEJOAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x15F0FD0", Offset = "0x15F03D0", VA = "0x1815F0FD0")]
	private static void GBIOIFHEFLF(GameObject GFIJINBOANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x15F0250", Offset = "0x15EF650", VA = "0x1815F0250")]
	public static void ALAEPKAEPIE(List<Renderer> EJGOHIIEKIP, List<Material> NJJFGNHFEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x15F0D00", Offset = "0x15F0100", VA = "0x1815F0D00")]
	public static void FFBPJHDIHHE(GameObject BLJDINJOMCN, Vector3 GBBPLJILBFB, Vector3 OMHELPGNAPO, float HMPHEEMFLDI, HKJDBEIEGIC MOCBBEJOAPJ, out Vector3 HLBKACNNONL, out Quaternion JOGINHIHIAE, out float OABHJABEELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x15F03F0", Offset = "0x15EF7F0", VA = "0x1815F03F0")]
	public static RenderTexture BCCPGNFIBND(int CNMMFNANECF, int OHIHFDKEEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x15F1740", Offset = "0x15F0B40", VA = "0x1815F1740")]
	public static void OGBOLAEGDBB()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct BHEHADHMCCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public LNFGPGAJEHA AMBPLHFJMFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public GameObject OBNJJLGAHJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RenderTexture DBELKFOBGHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ImposterRenderConfig EOCCKBOOPME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HKJDBEIEGIC HKJDBEIEGIC;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x15EC200", Offset = "0x15EB600", VA = "0x1815EC200")]
			public BHEHADHMCCF(LNFGPGAJEHA MDGHJEHFFEL, GameObject MMNDDPGOAKB, RenderTexture MDJHAOOHGFG, ImposterRenderConfig GLABHKPPDCN, HKJDBEIEGIC MOCBBEJOAPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static global::LGABAFLDHKL<BHEHADHMCCF, RenderTexture> FGMHJEHKHAM;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<BHEHADHMCCF> DFAOOGHINDE;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int ONPBHJGPOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x15EC5C0", Offset = "0x15EB9C0", VA = "0x1815EC5C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x15EC8A0", Offset = "0x15EBCA0", VA = "0x1815EC8A0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GFIJINBOANJ, RenderTexture MDJHAOOHGFG, ImposterRenderConfig BMCBPCECDMD, HKJDBEIEGIC MOCBBEJOAPJ, CancellationToken EMJFDFLJKFG, bool OLFFEPAGPGJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x15EC3D0", Offset = "0x15EB7D0", VA = "0x1815EC3D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x15EC800", Offset = "0x15EBC00", VA = "0x1815EC800", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x15EC630", Offset = "0x15EBA30", VA = "0x1815EC630")]
		private static Task<RenderTexture> MPFBDNMGGAD(BHEHADHMCCF HGILDMNBKNB, CancellationToken EMJFDFLJKFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x15ECC60", Offset = "0x15EC060", VA = "0x1815ECC60")]
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
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x15EFF20", Offset = "0x15EF320", VA = "0x1815EFF20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x15EFF00", Offset = "0x15EF300", VA = "0x1815EFF00")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x15EF700", Offset = "0x15EEB00", VA = "0x1815EF700")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class INCPBALNIAK : IDisposable, KOFFNIKBOAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HashSet<Type> NEKDCFJMHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HashSet<Type> JLEJHANNHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Transform AHIFKJDOGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly List<Component> CIFFFDKPNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JHKHCAEOBKA;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x15EE650", Offset = "0x15EDA50", VA = "0x1815EE650")]
	[HECCOHDEPAK(JCKMLGOOEHJ.None)]
	public static void MEFILDPHPHB(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x15EE740", Offset = "0x15EDB40", VA = "0x1815EE740")]
	[Preserve]
	public INCPBALNIAK([KFMNGACPMHN(null)] JFBKDFPCLCI NGMFAGDLLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x15EDC50", Offset = "0x15ED050", VA = "0x1815EDC50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x15EDBB0", Offset = "0x15ECFB0", VA = "0x1815EDBB0", Slot = "5")]
	public void AGAELNKENIC(params Type[] FKOMPPKIBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x15EDC00", Offset = "0x15ED000", VA = "0x1815EDC00", Slot = "6")]
	public void AOKKPENBAHB(params Type[] FKOMPPKIBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x15EE330", Offset = "0x15ED730", VA = "0x1815EE330", Slot = "7")]
	public GameObject GPCNIIGNBMG(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, bool KGAAGBCGFFM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF4F0", Offset = "0x2ECE8F0", VA = "0x182ECF4F0", Slot = "8")]
	public T GPCNIIGNBMG<T>(T BLJDINJOMCN, Transform MOHMMJFCOKF, bool KGAAGBCGFFM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF560", Offset = "0x2ECE960", VA = "0x182ECF560", Slot = "9")]
	public T GPCNIIGNBMG<T>(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, bool KGAAGBCGFFM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x15EE2A0", Offset = "0x15ED6A0", VA = "0x1815EE2A0", Slot = "10")]
	public GameObject GPCNIIGNBMG(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF410", Offset = "0x2ECE810", VA = "0x182ECF410", Slot = "11")]
	public T GPCNIIGNBMG<T>(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF460", Offset = "0x2ECE860", VA = "0x182ECF460", Slot = "12")]
	public T GPCNIIGNBMG<T>(T BLJDINJOMCN, Transform MOHMMJFCOKF, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF590", Offset = "0x2ECE990", VA = "0x182ECF590")]
	private T GPCNIIGNBMG<T>(GameObject BLJDINJOMCN, Transform MOHMMJFCOKF, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM, out GameObject KFEBIPGLABI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2ECFAC0", Offset = "0x2ECEEC0", VA = "0x182ECFAC0")]
	private T KPJKLDJMFCH<T>(GameObject NJMBJKHNCBN, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x15EE3C0", Offset = "0x15ED7C0", VA = "0x1815EE3C0")]
	private void IEAPIBHMEFA(Component COGHLJDPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x15EDD50", Offset = "0x15ED150", VA = "0x1815EDD50")]
	private void EEGHILHLDDD(Component COGHLJDPMKN, GIGFBDAKNKF IHHAIAFPENO, bool KGAAGBCGFFM, bool DEEIMMMIKCM, [Optional] Type BFFCEENKAAO, [Optional] Type BPIBNGDLGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x15EE4F0", Offset = "0x15ED8F0", VA = "0x1815EE4F0")]
	private void JGBHPCHDLKP(GameObject NJMBJKHNCBN)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, HLMFPEIHCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x15EC270", Offset = "0x15EB670", VA = "0x1815EC270", Slot = "4")]
		public void PrepareImposter(GIGFBDAKNKF IHHAIAFPENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GIGFBDAKNKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<Type, object> KCFIAJONEKD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5840", Offset = "0x2CE4C40", VA = "0x182CE5840")]
	public GIGFBDAKNKF BCHEBCENJDG<T>(T FLJMLJDEOOC)
	{
		return default(GIGFBDAKNKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6710", Offset = "0x2CE5B10", VA = "0x182CE6710")]
	public T LLPKLFBKNII<T>(T BICCJELLHLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5F70", Offset = "0x2CE5370", VA = "0x182CE5F70")]
	public bool EPJAPKGCCDE<T>(out T FLJMLJDEOOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JCKJAONIAIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool MPOOHAMLKDL;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x15EFB00", Offset = "0x15EEF00", VA = "0x1815EFB00")]
	public JCKJAONIAIM(bool OEOMDOLMILG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HNPEFEMHBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool MBOLDEGFENE;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x15EDBA0", Offset = "0x15ECFA0", VA = "0x1815EDBA0")]
	public HNPEFEMHBCE(bool GNBMAEAMPMI)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, HLMFPEIHCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x15F2DA0", Offset = "0x15F21A0", VA = "0x1815F2DA0", Slot = "4")]
		public void PrepareImposter(GIGFBDAKNKF IHHAIAFPENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HLMFPEIHCPC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GIGFBDAKNKF IHHAIAFPENO);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
